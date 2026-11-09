# Fact 7866364d

Store id: 47c6831d-4d77-4f66-8731-4e8f199a670d

## Text

```text
def set_source_expressions(self, exprs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.7601450+00:00`

## Data

```json
{
  "end_line": 2062,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2061,
  "symbol": "Window.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2061,"selector":"L2061-L2062","symbol":"Window.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2062,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2061,
    "symbol": "Window.set_source_expressions"
  },
  "id": "47c6831d-4d77-4f66-8731-4e8f199a670d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7601450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2061,
        "selector": "L2061-L2062",
        "symbol": "Window.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f9910a5f-0987-42d7-b465-02d3df25c2fa",
  "subject_name": "django/db/models/expressions::Window.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

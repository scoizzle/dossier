# Fact 7866364d

Store id: 6938491b-7ead-4113-b866-c03d39e81540

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
- posted_at: `2026-11-09T23:31:56.0032670+00:00`

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
  "id": "6938491b-7ead-4113-b866-c03d39e81540",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0032670+00:00"
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
  "subject_id": "6dc23a7e-1047-438e-8814-376ec4f2b85f",
  "subject_name": "django/db/models/expressions::Window.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

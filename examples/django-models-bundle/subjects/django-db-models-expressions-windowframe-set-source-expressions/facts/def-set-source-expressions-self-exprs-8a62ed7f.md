# Fact 8a62ed7f

Store id: bbe0c78c-ad41-43fb-8dbe-54a70e895f05

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
- posted_at: `2026-11-09T22:39:41.7765000+00:00`

## Data

```json
{
  "end_line": 2159,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2158,
  "symbol": "WindowFrame.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2158,"selector":"L2158-L2159","symbol":"WindowFrame.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2159,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2158,
    "symbol": "WindowFrame.set_source_expressions"
  },
  "id": "bbe0c78c-ad41-43fb-8dbe-54a70e895f05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7765000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2158,
        "selector": "L2158-L2159",
        "symbol": "WindowFrame.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e5bcf06f-ffaa-4413-a11b-c8b06743c159",
  "subject_name": "django/db/models/expressions::WindowFrame.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

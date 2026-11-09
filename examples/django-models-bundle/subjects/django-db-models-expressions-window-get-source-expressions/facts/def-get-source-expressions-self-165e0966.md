# Fact 165e0966

Store id: 19eff622-7bbd-43e1-b121-c0437fe8b35c

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T22:39:41.7579010+00:00`

## Data

```json
{
  "end_line": 2059,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2058,
  "symbol": "Window.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2058,"selector":"L2058-L2059","symbol":"Window.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2059,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2058,
    "symbol": "Window.get_source_expressions"
  },
  "id": "19eff622-7bbd-43e1-b121-c0437fe8b35c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7579010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2058,
        "selector": "L2058-L2059",
        "symbol": "Window.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9c72f624-e990-43b0-bab6-be8194dc1148",
  "subject_name": "django/db/models/expressions::Window.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

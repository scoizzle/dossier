# Fact 165e0966

Store id: 295fd978-1cb9-4303-a3ac-84a1700476b6

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
- posted_at: `2026-11-09T23:31:56.0021470+00:00`

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
  "id": "295fd978-1cb9-4303-a3ac-84a1700476b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0021470+00:00"
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
  "subject_id": "1ffcc0fd-458e-485c-9d0e-7530d5044c02",
  "subject_name": "django/db/models/expressions::Window.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

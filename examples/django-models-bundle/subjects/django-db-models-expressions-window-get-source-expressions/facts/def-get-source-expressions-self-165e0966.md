# Fact 165e0966

Store id: 641619b8-9f56-48b8-ba60-3aba6850ded6

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
- posted_at: `2026-11-09T23:44:49.6699690+00:00`

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
  "id": "641619b8-9f56-48b8-ba60-3aba6850ded6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6699690+00:00"
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
  "subject_id": "6421f5ae-1d70-4f3d-9f91-9e89102b8820",
  "subject_name": "django/db/models/expressions::Window.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

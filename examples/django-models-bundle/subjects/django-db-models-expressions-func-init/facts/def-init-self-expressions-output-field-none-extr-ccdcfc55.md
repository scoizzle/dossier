# Fact ccdcfc55

Store id: d5617612-5086-44f4-8cf8-a4f2982395d0

## Text

```text
def __init__(self, *expressions, output_field=None, **extra)
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
- posted_at: `2026-11-09T23:44:49.5087290+00:00`

## Data

```json
{
  "end_line": 1075,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1062,
  "symbol": "Func.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1062,"selector":"L1062-L1075","symbol":"Func.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1075,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1062,
    "symbol": "Func.__init__"
  },
  "id": "d5617612-5086-44f4-8cf8-a4f2982395d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5087290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1062,
        "selector": "L1062-L1075",
        "symbol": "Func.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3cec6483-d733-4a3b-8795-fddbd6e390e9",
  "subject_name": "django/db/models/expressions::Func.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, output_field=None, **extra)"
}
```

# Fact ccdcfc55

Store id: 1a253034-9337-4ada-a107-c79323b17748

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
- posted_at: `2026-11-09T23:31:55.8519130+00:00`

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
  "id": "1a253034-9337-4ada-a107-c79323b17748",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8519130+00:00"
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
  "subject_id": "69b9176c-c3b2-4ed9-a652-61935fdc5938",
  "subject_name": "django/db/models/expressions::Func.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, output_field=None, **extra)"
}
```

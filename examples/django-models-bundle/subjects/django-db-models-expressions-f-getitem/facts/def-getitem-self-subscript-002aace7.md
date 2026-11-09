# Fact 002aace7

Store id: 127f4409-e1da-4248-b54f-dc36ec2e92b0

## Text

```text
def __getitem__(self, subscript)
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
- posted_at: `2026-11-09T23:31:55.8325290+00:00`

## Data

```json
{
  "end_line": 898,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 897,
  "symbol": "F.__getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":897,"selector":"L897-L898","symbol":"F.__getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 898,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 897,
    "symbol": "F.__getitem__"
  },
  "id": "127f4409-e1da-4248-b54f-dc36ec2e92b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8325290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 897,
        "selector": "L897-L898",
        "symbol": "F.__getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "213e56ef-767b-479b-af55-8f21fe48fae4",
  "subject_name": "django/db/models/expressions::F.__getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getitem__(self, subscript)"
}
```

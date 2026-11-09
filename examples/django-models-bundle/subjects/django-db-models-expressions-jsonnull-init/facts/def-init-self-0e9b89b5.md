# Fact 0e9b89b5

Store id: 57f7f9f7-b2dd-497e-a040-1f47d247dca2

## Text

```text
def __init__(self)
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
- posted_at: `2026-11-09T23:44:49.5333040+00:00`

## Data

```json
{
  "end_line": 1251,
  "entity_kind": "method",
  "parent": "JSONNull",
  "start_line": 1248,
  "symbol": "JSONNull.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1248,"selector":"L1248-L1251","symbol":"JSONNull.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::JSONNull.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1251,
    "entity_kind": "method",
    "parent": "JSONNull",
    "start_line": 1248,
    "symbol": "JSONNull.__init__"
  },
  "id": "57f7f9f7-b2dd-497e-a040-1f47d247dca2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5333040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1248,
        "selector": "L1248-L1251",
        "symbol": "JSONNull.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f8bda3bd-1920-407c-bb3c-978074355af9",
  "subject_name": "django/db/models/expressions::JSONNull.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self)"
}
```

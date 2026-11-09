# Fact dea681e9

Store id: b0e8a309-bb3c-4d97-b915-97e4d0283e97

## Text

```text
def __init__(self, expression, filter=None, **extra)
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
- posted_at: `2026-11-09T22:39:40.0439350+00:00`

## Data

```json
{
  "end_line": 309,
  "entity_kind": "method",
  "parent": "Count",
  "start_line": 304,
  "symbol": "Count.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":304,"selector":"L304-L309","symbol":"Count.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Count.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 309,
    "entity_kind": "method",
    "parent": "Count",
    "start_line": 304,
    "symbol": "Count.__init__"
  },
  "id": "b0e8a309-bb3c-4d97-b915-97e4d0283e97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0439350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 304,
        "selector": "L304-L309",
        "symbol": "Count.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "b1e285c1-b6b1-497c-bb35-84a1332f91a9",
  "subject_name": "django/db/models/aggregates::Count.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, filter=None, **extra)"
}
```

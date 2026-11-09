# Fact 3e816cb1

Store id: 6fbeeaea-5159-4faf-a980-13a1aae4982c

## Text

```text
def __init__(self, sql, using, params=())
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
- posted_at: `2026-11-09T23:44:58.5390380+00:00`

## Data

```json
{
  "end_line": 168,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 158,
  "symbol": "RawQuery.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":158,"selector":"L158-L168","symbol":"RawQuery.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 168,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 158,
    "symbol": "RawQuery.__init__"
  },
  "id": "6fbeeaea-5159-4faf-a980-13a1aae4982c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5390380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 158,
        "selector": "L158-L168",
        "symbol": "RawQuery.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "15f59b2d-4575-4b82-b1c9-d41d782e4332",
  "subject_name": "django/db/models/sql/query::RawQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, sql, using, params=())"
}
```

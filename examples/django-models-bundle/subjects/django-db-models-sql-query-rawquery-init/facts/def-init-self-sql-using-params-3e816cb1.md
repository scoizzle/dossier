# Fact 3e816cb1

Store id: 00ac63f7-36ff-4705-9532-e6b3b3711c61

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
- posted_at: `2026-11-09T22:39:51.1860130+00:00`

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
  "id": "00ac63f7-36ff-4705-9532-e6b3b3711c61",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1860130+00:00"
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
  "subject_id": "15267ce6-a51b-489a-8818-33ef13f758d7",
  "subject_name": "django/db/models/sql/query::RawQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, sql, using, params=())"
}
```

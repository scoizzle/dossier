# Fact 59eafe0f

Store id: 93dfa084-e881-4578-a7b9-942aeea9a25a

## Text

```text
def __init__(self, *args, _connector=None, _negated=False, **kwargs)
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
- posted_at: `2026-11-09T23:32:05.0321040+00:00`

## Data

```json
{
  "end_line": 61,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 55,
  "symbol": "Q.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":55,"selector":"L55-L61","symbol":"Q.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 61,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 55,
    "symbol": "Q.__init__"
  },
  "id": "93dfa084-e881-4578-a7b9-942aeea9a25a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0321040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 55,
        "selector": "L55-L61",
        "symbol": "Q.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "151eb54f-29d8-459d-bc93-2e38db35a1e9",
  "subject_name": "django/db/models/query_utils::Q.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, _connector=None, _negated=False, **kwargs)"
}
```

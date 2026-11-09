# Fact 59eafe0f

Store id: b1e8ac95-56f4-4604-b931-9d2679c7a348

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
- posted_at: `2026-11-09T23:44:56.5096280+00:00`

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
  "id": "b1e8ac95-56f4-4604-b931-9d2679c7a348",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5096280+00:00"
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
  "subject_id": "4addcb20-663a-4288-818a-4042cbf9e60a",
  "subject_name": "django/db/models/query_utils::Q.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, _connector=None, _negated=False, **kwargs)"
}
```

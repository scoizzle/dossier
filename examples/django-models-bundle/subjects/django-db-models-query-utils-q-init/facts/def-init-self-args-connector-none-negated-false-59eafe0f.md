# Fact 59eafe0f

Store id: 62cf1585-f926-4693-8f3e-cd9d8ee55730

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
- posted_at: `2026-11-09T22:39:50.0497030+00:00`

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
  "id": "62cf1585-f926-4693-8f3e-cd9d8ee55730",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0497030+00:00"
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
  "subject_id": "1e7c6970-d99d-408f-8bc5-dec24433e311",
  "subject_name": "django/db/models/query_utils::Q.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, _connector=None, _negated=False, **kwargs)"
}
```

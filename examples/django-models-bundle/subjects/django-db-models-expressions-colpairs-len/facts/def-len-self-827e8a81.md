# Fact 827e8a81

Store id: c2ae1aa5-1915-43da-ba1d-dd2de1ca3578

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T23:31:55.9001400+00:00`

## Data

```json
{
  "end_line": 1398,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1397,
  "symbol": "ColPairs.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1397,"selector":"L1397-L1398","symbol":"ColPairs.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1398,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1397,
    "symbol": "ColPairs.__len__"
  },
  "id": "c2ae1aa5-1915-43da-ba1d-dd2de1ca3578",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9001400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1397,
        "selector": "L1397-L1398",
        "symbol": "ColPairs.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c25154a7-d061-4d12-a36e-14513debbf54",
  "subject_name": "django/db/models/expressions::ColPairs.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```

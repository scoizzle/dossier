# Fact 08d345ba

Store id: a3020339-eef2-401b-86c1-cb1aadb91cc7

## Text

```text
def __xor__(self, other)
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
- posted_at: `2026-11-09T23:44:56.5412230+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 93,
  "symbol": "Q.__xor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":93,"selector":"L93-L94","symbol":"Q.__xor__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__xor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 93,
    "symbol": "Q.__xor__"
  },
  "id": "a3020339-eef2-401b-86c1-cb1aadb91cc7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5412230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 93,
        "selector": "L93-L94",
        "symbol": "Q.__xor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "a3fa441e-6a48-4baa-8181-ddc283f5d702",
  "subject_name": "django/db/models/query_utils::Q.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```

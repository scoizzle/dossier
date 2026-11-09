# Fact 4359af28

Store id: f40f6c73-42b0-4bd4-8947-9b9bc81b3694

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:56.5910090+00:00`

## Data

```json
{
  "end_line": 231,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 228,
  "symbol": "Q.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":228,"selector":"L228-L231","symbol":"Q.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 231,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 228,
    "symbol": "Q.__eq__"
  },
  "id": "f40f6c73-42b0-4bd4-8947-9b9bc81b3694",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5910090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 228,
        "selector": "L228-L231",
        "symbol": "Q.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "80af09e4-ac46-425b-8c3f-f079d5b4081c",
  "subject_name": "django/db/models/query_utils::Q.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```

# Fact d1288c00

Store id: cde0979d-d1d4-4bbe-aba1-800fb676be39

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
- posted_at: `2026-11-09T22:39:49.8613720+00:00`

## Data

```json
{
  "end_line": 2628,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2625,
  "symbol": "Prefetch.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2625,"selector":"L2625-L2628","symbol":"Prefetch.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2628,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2625,
    "symbol": "Prefetch.__eq__"
  },
  "id": "cde0979d-d1d4-4bbe-aba1-800fb676be39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8613720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2625,
        "selector": "L2625-L2628",
        "symbol": "Prefetch.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3be76b46-cf4a-4d1a-b51c-9a28478ca9ce",
  "subject_name": "django/db/models/query::Prefetch.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```

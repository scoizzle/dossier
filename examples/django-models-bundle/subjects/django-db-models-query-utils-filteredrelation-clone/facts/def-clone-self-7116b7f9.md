# Fact 7116b7f9

Store id: 1c105159-9b6e-40ac-8281-9a4afbc191ea

## Text

```text
def clone(self)
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
- posted_at: `2026-11-09T22:39:50.1912430+00:00`

## Data

```json
{
  "end_line": 550,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 545,
  "symbol": "FilteredRelation.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":545,"selector":"L545-L550","symbol":"FilteredRelation.clone"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 550,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 545,
    "symbol": "FilteredRelation.clone"
  },
  "id": "1c105159-9b6e-40ac-8281-9a4afbc191ea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1912430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 545,
        "selector": "L545-L550",
        "symbol": "FilteredRelation.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "36375397-faf2-4a41-a96e-e3d218397a3a",
  "subject_name": "django/db/models/query_utils::FilteredRelation.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```

# Fact bc36af78

Store id: d18937e2-0250-4fcc-bb29-03299334ab2f

## Text

```text
def __init__(self, names_pos, path_with_names)
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
- posted_at: `2026-11-09T23:32:06.4285510+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "method",
  "parent": "MultiJoin",
  "start_line": 17,
  "symbol": "MultiJoin.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":17,"selector":"L17-L20","symbol":"MultiJoin.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::MultiJoin.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "method",
    "parent": "MultiJoin",
    "start_line": 17,
    "symbol": "MultiJoin.__init__"
  },
  "id": "d18937e2-0250-4fcc-bb29-03299334ab2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4285510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 17,
        "selector": "L17-L20",
        "symbol": "MultiJoin.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "55117c5b-cf51-4a9e-8d25-24a59b1aac6f",
  "subject_name": "django/db/models/sql/datastructures::MultiJoin.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, names_pos, path_with_names)"
}
```

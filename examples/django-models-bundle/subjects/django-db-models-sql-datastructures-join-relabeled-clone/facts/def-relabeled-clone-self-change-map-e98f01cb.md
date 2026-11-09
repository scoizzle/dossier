# Fact e98f01cb

Store id: b82ef157-0186-4e8d-94ab-64eb8326fbbe

## Text

```text
def relabeled_clone(self, change_map)
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
- posted_at: `2026-11-09T23:32:06.4587570+00:00`

## Data

```json
{
  "end_line": 150,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 135,
  "symbol": "Join.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L150","symbol":"Join.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 150,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 135,
    "symbol": "Join.relabeled_clone"
  },
  "id": "b82ef157-0186-4e8d-94ab-64eb8326fbbe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4587570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L150",
        "symbol": "Join.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "b315bc52-0a96-421e-936f-199996fdce51",
  "subject_name": "django/db/models/sql/datastructures::Join.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```

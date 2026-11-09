# Fact 62a819d1

Store id: 18790b6d-396b-4775-b917-4c66754e2495

## Text

```text
class OnConflict(Enum)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.6554000+00:00`

## Data

```json
{
  "end_line": 13,
  "entity_kind": "class",
  "parent": "constants",
  "start_line": 11,
  "symbol": "OnConflict"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constants.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":11,"selector":"L11-L13","symbol":"OnConflict"}`

## Referenced by

None.

## Subject

[django/db/models/constants::OnConflict](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 13,
    "entity_kind": "class",
    "parent": "constants",
    "start_line": 11,
    "symbol": "OnConflict"
  },
  "id": "18790b6d-396b-4775-b917-4c66754e2495",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.6554000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 11,
        "selector": "L11-L13",
        "symbol": "OnConflict"
      },
      "rel": "derived_from",
      "target": "django/db/models/constants.py"
    }
  ],
  "status": "live",
  "subject_id": "69661565-deb5-4949-b889-143c805ce940",
  "subject_name": "django/db/models/constants::OnConflict",
  "tags": [
    "entity:class"
  ],
  "text": "class OnConflict(Enum)"
}
```

# Fact b5f16c63

Store id: 9a81b3c1-b674-421f-9e45-257586306251

## Text

```text
class UniqueConstraint(BaseConstraint)
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
- posted_at: `2026-11-09T22:39:40.7208010+00:00`

## Data

```json
{
  "end_line": 686,
  "entity_kind": "class",
  "parent": "constraints",
  "start_line": 269,
  "symbol": "UniqueConstraint"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":269,"selector":"L269-L686","symbol":"UniqueConstraint"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 686,
    "entity_kind": "class",
    "parent": "constraints",
    "start_line": 269,
    "symbol": "UniqueConstraint"
  },
  "id": "9a81b3c1-b674-421f-9e45-257586306251",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7208010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 269,
        "selector": "L269-L686",
        "symbol": "UniqueConstraint"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "6d07c87a-2b23-416e-9586-82887bee9496",
  "subject_name": "django/db/models/constraints::UniqueConstraint",
  "tags": [
    "entity:class"
  ],
  "text": "class UniqueConstraint(BaseConstraint)"
}
```

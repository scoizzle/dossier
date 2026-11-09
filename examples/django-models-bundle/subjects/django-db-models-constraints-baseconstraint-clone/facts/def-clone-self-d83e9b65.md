# Fact d83e9b65

Store id: 16f05a36-c329-4e46-ba73-99c1f85cd517

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
- posted_at: `2026-11-09T22:39:40.7072740+00:00`

## Data

```json
{
  "end_line": 132,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 130,
  "symbol": "BaseConstraint.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":130,"selector":"L130-L132","symbol":"BaseConstraint.clone"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 132,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 130,
    "symbol": "BaseConstraint.clone"
  },
  "id": "16f05a36-c329-4e46-ba73-99c1f85cd517",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7072740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 130,
        "selector": "L130-L132",
        "symbol": "BaseConstraint.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "653a47ed-a094-4ce0-b5b9-36af69f91af8",
  "subject_name": "django/db/models/constraints::BaseConstraint.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```

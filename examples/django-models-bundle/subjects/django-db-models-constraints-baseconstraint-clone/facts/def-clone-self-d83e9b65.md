# Fact d83e9b65

Store id: 615a976b-f6f4-4464-9eea-0c75d9099ae7

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
- posted_at: `2026-11-09T23:31:54.1597030+00:00`

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
  "id": "615a976b-f6f4-4464-9eea-0c75d9099ae7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1597030+00:00"
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
  "subject_id": "88117118-e104-4b54-b2a1-f62fe3ceba07",
  "subject_name": "django/db/models/constraints::BaseConstraint.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```

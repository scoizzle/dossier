# Fact 982388c7

Store id: dc10d780-5fec-4e1f-b1a0-e95bd3004132

## Text

```text
def _check_references(self, model, references)
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
- posted_at: `2026-11-09T22:39:40.7033960+00:00`

## Data

```json
{
  "end_line": 115,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 77,
  "symbol": "BaseConstraint._check_references"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":77,"selector":"L77-L115","symbol":"BaseConstraint._check_references"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint._check_references](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 115,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 77,
    "symbol": "BaseConstraint._check_references"
  },
  "id": "dc10d780-5fec-4e1f-b1a0-e95bd3004132",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7033960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 77,
        "selector": "L77-L115",
        "symbol": "BaseConstraint._check_references"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "d125e440-cf85-4203-a65f-f144dc53239b",
  "subject_name": "django/db/models/constraints::BaseConstraint._check_references",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_references(self, model, references)"
}
```

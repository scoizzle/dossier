# Fact 7f99d706

Store id: 9df52f37-cccc-486f-bb78-db47117edd6a

## Text

```text
def target_field(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.2906050+00:00`

## Data

```json
{
  "end_line": 537,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 525,
  "symbol": "RelatedField.target_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":525,"selector":"L525-L537","symbol":"RelatedField.target_field"}`

## Items

```json
[
  {
    "text": "When filtering against this relation, return the field on the remote model against which the filtering should happen.",
    "locator": {
      "line": 527
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.target_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 537,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 525,
    "symbol": "RelatedField.target_field"
  },
  "id": "9df52f37-cccc-486f-bb78-db47117edd6a",
  "items": [
    {
      "locator": {
        "line": 527
      },
      "text": "When filtering against this relation, return the field on the remote model against which the filtering should happen."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2906050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 525,
        "selector": "L525-L537",
        "symbol": "RelatedField.target_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "eee57296-f620-4f96-b9fe-fe05a6af8c1b",
  "subject_name": "django/db/models/fields/related::RelatedField.target_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def target_field(self)"
}
```

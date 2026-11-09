# Fact 957de2d4

Store id: 8e3a5ea5-b18c-450a-b332-54343b874b76

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
- posted_at: `2026-11-09T23:32:00.2272520+00:00`

## Data

```json
{
  "end_line": 88,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 77,
  "symbol": "ForeignObjectRel.target_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":77,"selector":"L77-L88","symbol":"ForeignObjectRel.target_field"}`

## Items

```json
[
  {
    "text": "When filtering against this relation, return the field on the remote model against which the filtering should happen.",
    "locator": {
      "line": 79
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.target_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 88,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 77,
    "symbol": "ForeignObjectRel.target_field"
  },
  "id": "8e3a5ea5-b18c-450a-b332-54343b874b76",
  "items": [
    {
      "locator": {
        "line": 79
      },
      "text": "When filtering against this relation, return the field on the remote model against which the filtering should happen."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2272520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 77,
        "selector": "L77-L88",
        "symbol": "ForeignObjectRel.target_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "353aaec9-6337-48f5-bb8e-b993c8f5fc84",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.target_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def target_field(self)"
}
```

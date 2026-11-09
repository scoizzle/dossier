# Fact b0c383bd

Store id: 4b95d30a-1696-4f0b-9b25-f32b14791097

## Text

```text
def resolve_related_fields(self)
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
- posted_at: `2026-11-09T23:44:51.5832110+00:00`

## Data

```json
{
  "end_line": 1256,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1239,
  "symbol": "ForeignKey.resolve_related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1239,"selector":"L1239-L1256","symbol":"ForeignKey.resolve_related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.resolve_related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1256,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1239,
    "symbol": "ForeignKey.resolve_related_fields"
  },
  "id": "4b95d30a-1696-4f0b-9b25-f32b14791097",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5832110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1239,
        "selector": "L1239-L1256",
        "symbol": "ForeignKey.resolve_related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "06e41449-5e4d-418b-a6f0-1124d72ba730",
  "subject_name": "django/db/models/fields/related::ForeignKey.resolve_related_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_related_fields(self)"
}
```

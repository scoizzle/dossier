# Fact b0c383bd

Store id: 73c30143-eace-42f3-a788-bfe76106e2c4

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
- posted_at: `2026-11-09T22:39:44.3904190+00:00`

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
  "id": "73c30143-eace-42f3-a788-bfe76106e2c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3904190+00:00"
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
  "subject_id": "eb521318-e099-4e24-a8a6-5fc24828292a",
  "subject_name": "django/db/models/fields/related::ForeignKey.resolve_related_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_related_fields(self)"
}
```

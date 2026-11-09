# Fact 1fcb5da2

Store id: f232c0ca-21ab-4a2b-ba8d-07fe7cc4f44a

## Text

```text
def contribute_to_related_class(self, cls, related)
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
- posted_at: `2026-11-09T23:31:58.7754220+00:00`

## Data

```json
{
  "end_line": 1294,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1291,
  "symbol": "ForeignKey.contribute_to_related_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1291,"selector":"L1291-L1294","symbol":"ForeignKey.contribute_to_related_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.contribute_to_related_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1294,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1291,
    "symbol": "ForeignKey.contribute_to_related_class"
  },
  "id": "f232c0ca-21ab-4a2b-ba8d-07fe7cc4f44a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7754220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1291,
        "selector": "L1291-L1294",
        "symbol": "ForeignKey.contribute_to_related_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "06b3dc80-c98c-4e9c-9b3d-7ac1fb366b93",
  "subject_name": "django/db/models/fields/related::ForeignKey.contribute_to_related_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_related_class(self, cls, related)"
}
```

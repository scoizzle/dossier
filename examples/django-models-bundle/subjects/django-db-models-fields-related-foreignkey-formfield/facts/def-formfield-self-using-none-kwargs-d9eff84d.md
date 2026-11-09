# Fact d9eff84d

Store id: a832e65e-cbd5-46b0-befa-af0bc3d0d5a2

## Text

```text
def formfield(self, *, using=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.5993220+00:00`

## Data

```json
{
  "end_line": 1311,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1296,
  "symbol": "ForeignKey.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1296,"selector":"L1296-L1311","symbol":"ForeignKey.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1311,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1296,
    "symbol": "ForeignKey.formfield"
  },
  "id": "a832e65e-cbd5-46b0-befa-af0bc3d0d5a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5993220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1296,
        "selector": "L1296-L1311",
        "symbol": "ForeignKey.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "14f38828-c95f-45a7-885f-7f65a06feb71",
  "subject_name": "django/db/models/fields/related::ForeignKey.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, *, using=None, **kwargs)"
}
```

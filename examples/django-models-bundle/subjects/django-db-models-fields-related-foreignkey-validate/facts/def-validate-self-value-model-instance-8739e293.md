# Fact 8739e293

Store id: f48a72d3-2ec7-4426-aa9b-d6712ac39b3c

## Text

```text
def validate(self, value, model_instance)
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
- posted_at: `2026-11-09T22:39:44.3885690+00:00`

## Data

```json
{
  "end_line": 1237,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1215,
  "symbol": "ForeignKey.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1215,"selector":"L1215-L1237","symbol":"ForeignKey.validate"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1237,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1215,
    "symbol": "ForeignKey.validate"
  },
  "id": "f48a72d3-2ec7-4426-aa9b-d6712ac39b3c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3885690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1215,
        "selector": "L1215-L1237",
        "symbol": "ForeignKey.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e31c4ab0-f7ee-4e94-8367-ce9384861044",
  "subject_name": "django/db/models/fields/related::ForeignKey.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

# Fact 8739e293

Store id: 2ef60207-9e1d-4223-a703-0ac1abc984f0

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
- posted_at: `2026-11-09T23:31:58.7589620+00:00`

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
  "id": "2ef60207-9e1d-4223-a703-0ac1abc984f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7589620+00:00"
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
  "subject_id": "f2448d1d-0050-4c0e-89d0-7c5ff63d93ce",
  "subject_name": "django/db/models/fields/related::ForeignKey.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

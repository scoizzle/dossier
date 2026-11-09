# Fact 8535bcfb

Store id: 04da09b2-0ce1-4fe7-840e-c26c110732b3

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
- posted_at: `2026-11-09T22:39:44.3858810+00:00`

## Data

```json
{
  "end_line": 1213,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1211,
  "symbol": "ForeignKey.target_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1211,"selector":"L1211-L1213","symbol":"ForeignKey.target_field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.target_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1213,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1211,
    "symbol": "ForeignKey.target_field"
  },
  "id": "04da09b2-0ce1-4fe7-840e-c26c110732b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3858810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1211,
        "selector": "L1211-L1213",
        "symbol": "ForeignKey.target_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "b401f741-a65c-4525-9c74-496a51b1d2f1",
  "subject_name": "django/db/models/fields/related::ForeignKey.target_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def target_field(self)"
}
```

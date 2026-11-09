# Fact 8535bcfb

Store id: ca8cd57d-7564-49d8-93ff-09b7477479bb

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
- posted_at: `2026-11-09T23:31:58.7566940+00:00`

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
  "id": "ca8cd57d-7564-49d8-93ff-09b7477479bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7566940+00:00"
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
  "subject_id": "f2358a76-8c57-4c4b-9a18-abcaa06dc91e",
  "subject_name": "django/db/models/fields/related::ForeignKey.target_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def target_field(self)"
}
```

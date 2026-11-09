# Fact 8535bcfb

Store id: 49a22c64-89c9-4680-9b34-1c48446fcc19

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
- posted_at: `2026-11-09T23:44:51.5788390+00:00`

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
  "id": "49a22c64-89c9-4680-9b34-1c48446fcc19",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5788390+00:00"
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
  "subject_id": "90c63ab2-2dcc-4bf5-8472-cefd34cf4426",
  "subject_name": "django/db/models/fields/related::ForeignKey.target_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def target_field(self)"
}
```

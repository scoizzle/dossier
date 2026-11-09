# Fact 0b56a5c5

Store id: e9bad34b-fcaf-47b9-a104-381a90645128

## Text

```text
def get_attname_column(self)
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
- posted_at: `2026-11-09T23:44:51.5870260+00:00`

## Data

```json
{
  "end_line": 1264,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1261,
  "symbol": "ForeignKey.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1261,"selector":"L1261-L1264","symbol":"ForeignKey.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1264,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1261,
    "symbol": "ForeignKey.get_attname_column"
  },
  "id": "e9bad34b-fcaf-47b9-a104-381a90645128",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5870260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1261,
        "selector": "L1261-L1264",
        "symbol": "ForeignKey.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "f0681de9-1635-449e-b1b2-3499dd9d2245",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```

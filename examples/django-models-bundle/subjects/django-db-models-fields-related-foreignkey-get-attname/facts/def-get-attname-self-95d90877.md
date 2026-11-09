# Fact 95d90877

Store id: 21e52174-c8e7-4c0f-8130-35d1b96bd7d7

## Text

```text
def get_attname(self)
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
- posted_at: `2026-11-09T22:39:44.3925400+00:00`

## Data

```json
{
  "end_line": 1259,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1258,
  "symbol": "ForeignKey.get_attname"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1258,"selector":"L1258-L1259","symbol":"ForeignKey.get_attname"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_attname](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1259,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1258,
    "symbol": "ForeignKey.get_attname"
  },
  "id": "21e52174-c8e7-4c0f-8130-35d1b96bd7d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3925400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1258,
        "selector": "L1258-L1259",
        "symbol": "ForeignKey.get_attname"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "48b601f6-5c70-45f0-aade-15c5a53799d6",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_attname",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname(self)"
}
```

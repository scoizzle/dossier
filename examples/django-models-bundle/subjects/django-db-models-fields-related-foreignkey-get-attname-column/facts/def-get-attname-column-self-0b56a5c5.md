# Fact 0b56a5c5

Store id: 86db245c-1934-4d94-96b4-df27ddaa4447

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
- posted_at: `2026-11-09T22:39:44.3955130+00:00`

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
  "id": "86db245c-1934-4d94-96b4-df27ddaa4447",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3955130+00:00"
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
  "subject_id": "a8962094-cc1a-4d4f-8072-ca5c95eb1ea7",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```

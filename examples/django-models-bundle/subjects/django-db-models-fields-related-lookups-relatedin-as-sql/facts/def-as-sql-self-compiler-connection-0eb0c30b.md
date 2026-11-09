# Fact 0eb0c30b

Store id: 7ec27275-b9f8-4d7b-812a-ce7b8823055b

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:52.2462770+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "method",
  "parent": "RelatedIn",
  "start_line": 86,
  "symbol": "RelatedIn.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":86,"selector":"L86-L95","symbol":"RelatedIn.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedIn.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "method",
    "parent": "RelatedIn",
    "start_line": 86,
    "symbol": "RelatedIn.as_sql"
  },
  "id": "7ec27275-b9f8-4d7b-812a-ce7b8823055b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2462770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 86,
        "selector": "L86-L95",
        "symbol": "RelatedIn.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "bf842fe4-7e65-4aa5-899e-e7c1d758e38c",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIn.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```

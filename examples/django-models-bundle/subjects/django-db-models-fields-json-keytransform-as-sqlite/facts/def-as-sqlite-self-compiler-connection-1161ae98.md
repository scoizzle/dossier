# Fact 1161ae98

Store id: 210782ea-828f-490c-ba83-cc4ab5c3057b

## Text

```text
def as_sqlite(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:51.0265870+00:00`

## Data

```json
{
  "end_line": 537,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 535,
  "symbol": "KeyTransform.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":535,"selector":"L535-L537","symbol":"KeyTransform.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 537,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 535,
    "symbol": "KeyTransform.as_sqlite"
  },
  "id": "210782ea-828f-490c-ba83-cc4ab5c3057b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0265870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 535,
        "selector": "L535-L537",
        "symbol": "KeyTransform.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7bea25eb-ec2c-4707-9fab-ad928e032fc5",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```

# Fact e5b93443

Store id: 7d50d153-9486-4774-acdb-278e63eb06df

## Text

```text
class KeyTransformStartsWith(KeyTransformTextLookupMixin, lookups.StartsWith)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.0144860+00:00`

## Data

```json
{
  "end_line": 691,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 690,
  "symbol": "KeyTransformStartsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":690,"selector":"L690-L691","symbol":"KeyTransformStartsWith"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformStartsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 691,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 690,
    "symbol": "KeyTransformStartsWith"
  },
  "id": "7d50d153-9486-4774-acdb-278e63eb06df",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0144860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 690,
        "selector": "L690-L691",
        "symbol": "KeyTransformStartsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "2af1d424-e02b-479a-932c-fe2a130890b4",
  "subject_name": "django/db/models/fields/json::KeyTransformStartsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformStartsWith(KeyTransformTextLookupMixin, lookups.StartsWith)"
}
```

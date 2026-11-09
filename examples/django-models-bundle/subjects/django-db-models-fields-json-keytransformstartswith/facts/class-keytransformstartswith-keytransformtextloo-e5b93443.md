# Fact e5b93443

Store id: 5b61570a-08cd-477a-93ce-c4d97513e5b4

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
- posted_at: `2026-11-09T23:44:51.0519910+00:00`

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
  "id": "5b61570a-08cd-477a-93ce-c4d97513e5b4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0519910+00:00"
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
  "subject_id": "5754cef3-0405-4260-8d26-9b6a355cb8f4",
  "subject_name": "django/db/models/fields/json::KeyTransformStartsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformStartsWith(KeyTransformTextLookupMixin, lookups.StartsWith)"
}
```

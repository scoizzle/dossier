# Fact a6340613

Store id: de70780d-66cb-4ab7-a16a-cffc299ca70e

## Text

```text
def get_instance_lookups(self)
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
- posted_at: `2026-11-09T23:32:05.1535370+00:00`

## Data

```json
{
  "end_line": 351,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 347,
  "symbol": "RegisterLookupMixin.get_instance_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":347,"selector":"L347-L351","symbol":"RegisterLookupMixin.get_instance_lookups"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.get_instance_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 351,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 347,
    "symbol": "RegisterLookupMixin.get_instance_lookups"
  },
  "id": "de70780d-66cb-4ab7-a16a-cffc299ca70e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1535370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 347,
        "selector": "L347-L351",
        "symbol": "RegisterLookupMixin.get_instance_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "e8fbf6e1-3fa7-420e-8a69-c782b3a19df6",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_instance_lookups",
  "tags": [
    "entity:method"
  ],
  "text": "def get_instance_lookups(self)"
}
```

# Fact a6340613

Store id: fd0b0dc4-4bca-44e5-874d-ce847625473f

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
- posted_at: `2026-11-09T23:44:56.6720870+00:00`

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
  "id": "fd0b0dc4-4bca-44e5-874d-ce847625473f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6720870+00:00"
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
  "subject_id": "4427d15a-b14a-403c-8a42-f46c81aa868b",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_instance_lookups",
  "tags": [
    "entity:method"
  ],
  "text": "def get_instance_lookups(self)"
}
```

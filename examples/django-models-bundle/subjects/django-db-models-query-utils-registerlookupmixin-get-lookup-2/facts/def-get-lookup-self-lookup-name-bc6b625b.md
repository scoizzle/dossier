# Fact bc6b625b

Store id: 4e730f9b-071d-4b85-8e18-9f8d2534ec69

## Text

```text
def get_lookup(self, lookup_name)
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
- posted_at: `2026-11-09T23:44:56.6766720+00:00`

## Data

```json
{
  "end_line": 364,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 356,
  "symbol": "RegisterLookupMixin.get_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":356,"selector":"L356-L364","symbol":"RegisterLookupMixin.get_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.get_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 364,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 356,
    "symbol": "RegisterLookupMixin.get_lookup"
  },
  "id": "4e730f9b-071d-4b85-8e18-9f8d2534ec69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6766720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 356,
        "selector": "L356-L364",
        "symbol": "RegisterLookupMixin.get_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "41dcd8ae-4403-4292-9df3-062f739b4236",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lookup(self, lookup_name)"
}
```

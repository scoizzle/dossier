# Fact e8ad3f5f

Store id: 30c4fc36-ac9d-49b4-adcc-e1d7b37dc512

## Text

```text
def _unregister_instance_lookup(self, lookup, lookup_name=None)
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
- posted_at: `2026-11-09T23:32:05.1825570+00:00`

## Data

```json
{
  "end_line": 432,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 425,
  "symbol": "RegisterLookupMixin._unregister_instance_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":425,"selector":"L425-L432","symbol":"RegisterLookupMixin._unregister_instance_lookup"}`

## Items

```json
[
  {
    "text": "Remove given lookup from instance lookups. For use in tests only as it's not thread-safe.",
    "locator": {
      "line": 426
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin._unregister_instance_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 432,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 425,
    "symbol": "RegisterLookupMixin._unregister_instance_lookup"
  },
  "id": "30c4fc36-ac9d-49b4-adcc-e1d7b37dc512",
  "items": [
    {
      "locator": {
        "line": 426
      },
      "text": "Remove given lookup from instance lookups. For use in tests only as it's not thread-safe."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1825570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 425,
        "selector": "L425-L432",
        "symbol": "RegisterLookupMixin._unregister_instance_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "d42ee273-74c3-4a29-acc6-960f56ee856b",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin._unregister_instance_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def _unregister_instance_lookup(self, lookup, lookup_name=None)"
}
```

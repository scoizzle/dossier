# Fact 5b023c8a

Store id: 880de40d-46d4-47f8-95d0-45885de3ed10

## Text

```text
def _unregister_class_lookup(cls, lookup, lookup_name=None)
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
- posted_at: `2026-11-09T23:44:56.7049070+00:00`

## Data

```json
{
  "end_line": 423,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 415,
  "symbol": "RegisterLookupMixin._unregister_class_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":415,"selector":"L415-L423","symbol":"RegisterLookupMixin._unregister_class_lookup"}`

## Items

```json
[
  {
    "text": "Remove given lookup from cls lookups. For use in tests only as it's not thread-safe.",
    "locator": {
      "line": 416
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin._unregister_class_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 423,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 415,
    "symbol": "RegisterLookupMixin._unregister_class_lookup"
  },
  "id": "880de40d-46d4-47f8-95d0-45885de3ed10",
  "items": [
    {
      "locator": {
        "line": 416
      },
      "text": "Remove given lookup from cls lookups. For use in tests only as it's not thread-safe."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7049070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 415,
        "selector": "L415-L423",
        "symbol": "RegisterLookupMixin._unregister_class_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "40afaf8f-9b49-4cec-a534-d26cbcd3c6ad",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin._unregister_class_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def _unregister_class_lookup(cls, lookup, lookup_name=None)"
}
```

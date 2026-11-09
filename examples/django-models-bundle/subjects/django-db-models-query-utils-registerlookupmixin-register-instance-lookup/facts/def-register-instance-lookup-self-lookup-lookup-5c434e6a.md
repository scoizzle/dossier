# Fact 5c434e6a

Store id: b7436452-74a2-4a0c-aa87-ed26eb752356

## Text

```text
def register_instance_lookup(self, lookup, lookup_name=None)
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
- posted_at: `2026-11-09T23:44:56.6994240+00:00`

## Data

```json
{
  "end_line": 408,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 402,
  "symbol": "RegisterLookupMixin.register_instance_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":402,"selector":"L402-L408","symbol":"RegisterLookupMixin.register_instance_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.register_instance_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 408,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 402,
    "symbol": "RegisterLookupMixin.register_instance_lookup"
  },
  "id": "b7436452-74a2-4a0c-aa87-ed26eb752356",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6994240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 402,
        "selector": "L402-L408",
        "symbol": "RegisterLookupMixin.register_instance_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "fdb74e81-35c7-4a82-a71a-e173f8c8d710",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.register_instance_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def register_instance_lookup(self, lookup, lookup_name=None)"
}
```

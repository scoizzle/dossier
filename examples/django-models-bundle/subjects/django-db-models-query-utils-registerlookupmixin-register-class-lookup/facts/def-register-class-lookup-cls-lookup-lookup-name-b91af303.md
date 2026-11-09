# Fact b91af303

Store id: e85c664e-2650-42e7-a130-02706b07d32d

## Text

```text
def register_class_lookup(cls, lookup, lookup_name=None)
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
- posted_at: `2026-11-09T23:32:05.1723500+00:00`

## Data

```json
{
  "end_line": 400,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 393,
  "symbol": "RegisterLookupMixin.register_class_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":393,"selector":"L393-L400","symbol":"RegisterLookupMixin.register_class_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.register_class_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 400,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 393,
    "symbol": "RegisterLookupMixin.register_class_lookup"
  },
  "id": "e85c664e-2650-42e7-a130-02706b07d32d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1723500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 393,
        "selector": "L393-L400",
        "symbol": "RegisterLookupMixin.register_class_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "4cbcc573-075b-40b3-8121-072d61ba50c0",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.register_class_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def register_class_lookup(cls, lookup, lookup_name=None)"
}
```

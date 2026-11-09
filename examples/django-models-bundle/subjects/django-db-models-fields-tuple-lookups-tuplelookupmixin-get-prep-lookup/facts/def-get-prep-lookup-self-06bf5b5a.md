# Fact 06bf5b5a

Store id: 325d1e22-b86e-4cd6-9f57-fd40c35d35fc

## Text

```text
def get_prep_lookup(self)
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
- posted_at: `2026-11-09T23:44:52.6997550+00:00`

## Data

```json
{
  "end_line": 60,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 53,
  "symbol": "TupleLookupMixin.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":53,"selector":"L53-L60","symbol":"TupleLookupMixin.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 60,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 53,
    "symbol": "TupleLookupMixin.get_prep_lookup"
  },
  "id": "325d1e22-b86e-4cd6-9f57-fd40c35d35fc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.6997550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 53,
        "selector": "L53-L60",
        "symbol": "TupleLookupMixin.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "28e531a0-3646-495c-ad86-71cba302c5b0",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```

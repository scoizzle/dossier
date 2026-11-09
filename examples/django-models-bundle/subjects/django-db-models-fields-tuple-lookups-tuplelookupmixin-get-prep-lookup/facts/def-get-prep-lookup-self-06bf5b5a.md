# Fact 06bf5b5a

Store id: 89dad5f7-33d4-47c0-aa10-ec339b30918f

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
- posted_at: `2026-11-09T23:32:00.5400130+00:00`

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
  "id": "89dad5f7-33d4-47c0-aa10-ec339b30918f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5400130+00:00"
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
  "subject_id": "8fad06e2-abcf-4ab3-bf55-d943356e7d60",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```

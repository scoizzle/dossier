# Fact 32cc8fc9

Store id: 25d502ea-c226-4760-bf1f-7bb5441ca8df

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
- posted_at: `2026-11-09T23:44:54.8608010+00:00`

## Data

```json
{
  "end_line": 97,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 89,
  "symbol": "Lookup.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":89,"selector":"L89-L97","symbol":"Lookup.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 97,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 89,
    "symbol": "Lookup.get_prep_lookup"
  },
  "id": "25d502ea-c226-4760-bf1f-7bb5441ca8df",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8608010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 89,
        "selector": "L89-L97",
        "symbol": "Lookup.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "15161188-9902-49f9-a68a-4825b7448efd",
  "subject_name": "django/db/models/lookups::Lookup.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```

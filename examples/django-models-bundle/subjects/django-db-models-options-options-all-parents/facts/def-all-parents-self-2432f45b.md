# Fact 2432f45b

Store id: dcdc0d49-dbf2-438c-8f9c-9362d6963917

## Text

```text
def all_parents(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.0067080+00:00`

## Data

```json
{
  "end_line": 725,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 714,
  "symbol": "Options.all_parents"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":714,"selector":"L714-L725","symbol":"Options.all_parents"}`

## Items

```json
[
  {
    "text": "Return all the ancestors of this model as a tuple ordered by MRO. Useful for determining if something is an ancestor, regardless of lineage.",
    "locator": {
      "line": 716
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.all_parents](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 725,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 714,
    "symbol": "Options.all_parents"
  },
  "id": "dcdc0d49-dbf2-438c-8f9c-9362d6963917",
  "items": [
    {
      "locator": {
        "line": 716
      },
      "text": "Return all the ancestors of this model as a tuple ordered by MRO. Useful for determining if something is an ancestor, regardless of lineage."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.0067080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 714,
        "selector": "L714-L725",
        "symbol": "Options.all_parents"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "0e53c959-7640-41b6-84f3-738249cac694",
  "subject_name": "django/db/models/options::Options.all_parents",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def all_parents(self)"
}
```

# Fact 2432f45b

Store id: 2c14d700-0b73-4b42-b846-a1a8314467ed

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
- posted_at: `2026-11-09T23:44:55.5574420+00:00`

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
  "id": "2c14d700-0b73-4b42-b846-a1a8314467ed",
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
    "posted_at": "2026-11-09T23:44:55.5574420+00:00"
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
  "subject_id": "875fe346-5229-49ca-992b-2b311020e9dc",
  "subject_name": "django/db/models/options::Options.all_parents",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def all_parents(self)"
}
```

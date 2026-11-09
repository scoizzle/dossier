# Fact 8e76e1aa

Store id: ff773d26-171f-43b2-87f8-467dfb32e755

## Text

```text
def contains_expressions(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.7854630+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 340,
  "symbol": "UniqueConstraint.contains_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L342","symbol":"UniqueConstraint.contains_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.contains_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 340,
    "symbol": "UniqueConstraint.contains_expressions"
  },
  "id": "ff773d26-171f-43b2-87f8-467dfb32e755",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7854630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L342",
        "symbol": "UniqueConstraint.contains_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "0e412f92-36e0-4a77-932a-02f048d77860",
  "subject_name": "django/db/models/constraints::UniqueConstraint.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```

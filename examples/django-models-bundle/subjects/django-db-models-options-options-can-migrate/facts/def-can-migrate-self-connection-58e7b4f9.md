# Fact 58e7b4f9

Store id: f4c693fd-0a86-49d5-88ae-fb808435d46a

## Text

```text
def can_migrate(self, connection)
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
- posted_at: `2026-11-09T22:39:48.8101970+00:00`

## Data

```json
{
  "end_line": 411,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 395,
  "symbol": "Options.can_migrate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":395,"selector":"L395-L411","symbol":"Options.can_migrate"}`

## Items

```json
[
  {
    "text": "Return True if the model can/should be migrated on the `connection`. `connection` can be either a real connection or a connection alias.",
    "locator": {
      "line": 396
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.can_migrate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 411,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 395,
    "symbol": "Options.can_migrate"
  },
  "id": "f4c693fd-0a86-49d5-88ae-fb808435d46a",
  "items": [
    {
      "locator": {
        "line": 396
      },
      "text": "Return True if the model can/should be migrated on the `connection`. `connection` can be either a real connection or a connection alias."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8101970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 395,
        "selector": "L395-L411",
        "symbol": "Options.can_migrate"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "4598865a-d248-4599-9e7a-9abc369a0804",
  "subject_name": "django/db/models/options::Options.can_migrate",
  "tags": [
    "entity:method"
  ],
  "text": "def can_migrate(self, connection)"
}
```

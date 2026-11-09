# Fact 23857e49

Store id: 6603a59d-d088-46cf-98a3-fbc6bc67b8cf

## Text

```text
def as_oracle(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.9566170+00:00`

## Data

```json
{
  "end_line": 483,
  "entity_kind": "method",
  "parent": "JSONIn",
  "start_line": 464,
  "symbol": "JSONIn.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":464,"selector":"L464-L483","symbol":"JSONIn.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONIn.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 483,
    "entity_kind": "method",
    "parent": "JSONIn",
    "start_line": 464,
    "symbol": "JSONIn.as_oracle"
  },
  "id": "6603a59d-d088-46cf-98a3-fbc6bc67b8cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9566170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 464,
        "selector": "L464-L483",
        "symbol": "JSONIn.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "ba27a894-4997-4bd3-9f72-3ff0d415a056",
  "subject_name": "django/db/models/fields/json::JSONIn.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```

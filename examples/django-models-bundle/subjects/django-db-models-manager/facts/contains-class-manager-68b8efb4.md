# Fact 68b8efb4

Store id: c3aeeefa-c5b6-4734-8ddd-dbaed8375695

## Text

```text
contains class Manager
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.3295960+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/manager::Manager](../../django-db-models-manager-manager/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"symbol":"Manager"}`

## Referenced by

None.

## Subject

[django/db/models/manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "c3aeeefa-c5b6-4734-8ddd-dbaed8375695",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3295960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 176,
        "symbol": "Manager"
      },
      "rel": "contains",
      "target": "d7fe8e4c-e577-4ffe-b97f-a2b18b04534f"
    }
  ],
  "status": "live",
  "subject_id": "dc0aeb12-8c7a-413b-aab2-e5de5c51b999",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Manager"
}
```
